import os
import json
import re

# Configuration
ENTITIES_DIR = r"c:\ZFinal\Consulcon.Domain\Entities"
OUTPUT_FILE = r"c:\ZFinal\postman_collection.json"
BASE_URL = "{{baseUrl}}"

# Entities to ignore (if any, e.g., Base classes)
IGNORE = ["AuditableEntity.cs"]

def parse_properties(filepath):
    """
    Parses a C# file and returns a dict of PropertyName -> ExampleValue
    """
    props = {}
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()
        
    # Regex to find properties: public type Name { get; set; }
    # Supporting nullable types (?)
    matches = re.finditer(r"public\s+(?:required\s+)?([a-zA-Z0-9_?<>]+)\s+([a-zA-Z0-9_]+)\s*\{\s*get;\s*set;\s*\}", content)
    
    for m in matches:
        dtype = m.group(1)
        name = m.group(2)
        name_lower = name.lower()
        
        # Default value
        val = "test_data"
        
        if "int" in dtype:
            val = 1
            if name_lower.startswith("pk"):
                val = 0 # Auto-inc
            elif name_lower.startswith("fk"):
                val = 1
        elif "decimal" in dtype or "double" in dtype or "float" in dtype:
            val = 10.50
        elif "DateTime" in dtype:
            val = "2024-01-01T12:00:00"
        elif "bool" in dtype:
            val = True
        elif "string" in dtype:
            # Handle short columns logic
            if name_lower == "activo" or name_lower == "habilitado":
                val = "SI"
            elif name_lower == "sexo":
                val = "M"
            elif name_lower == "estado" or name_lower == "estatus":
                val = "AC"
            elif "tipo" in name_lower:
                 val = "T1"
            elif "documento" in name_lower or "ci" in name_lower:
                val = "123456"
            
        props[name] = val
        
    return props

def generate_collection():
    items = []
    
    files = [f for f in os.listdir(ENTITIES_DIR) if f.endswith(".cs")]
    files.sort()
    
    for f in files:
        if f in IGNORE:
            continue
            
        entity_name = f.replace(".cs", "")
        resource_path = "api/" + entity_name
        
        sample_body = parse_properties(os.path.join(ENTITIES_DIR, f))
        
        # POST body (PK = 0)
        post_body = sample_body.copy()
        for k in post_body.keys():
            if k.lower().startswith("pk"):
                post_body[k] = 0
                
        # PUT body (PK = 1)
        put_body = sample_body.copy()
        for k in put_body.keys():
            if k.lower().startswith("pk"):
                put_body[k] = 1 # Update 1
        
        entity_folder = {
            "name": entity_name,
            "item": [
                {
                    "name": f"Get All {entity_name}s",
                    "request": {
                        "method": "GET",
                        "header": [],
                        "url": {
                            "raw": f"{BASE_URL}/{resource_path}",
                            "host": ["{{baseUrl}}"],
                            "path": ["api", entity_name]
                        }
                    },
                    "response": []
                },
                {
                    "name": f"Create {entity_name}",
                    "request": {
                        "method": "POST",
                        "header": [{"key": "Content-Type", "value": "application/json", "type": "text"}],
                        "body": {
                            "mode": "raw",
                            "raw": json.dumps(post_body, indent=4)
                        },
                        "url": {
                            "raw": f"{BASE_URL}/{resource_path}",
                            "host": ["{{baseUrl}}"],
                            "path": ["api", entity_name]
                        }
                    },
                    "response": []
                },
                {
                   "name": f"Update {entity_name}",
                    "request": {
                        "method": "PUT",
                        "header": [{"key": "Content-Type", "value": "application/json", "type": "text"}],
                        "body": {
                            "mode": "raw",
                            "raw": json.dumps(put_body, indent=4)
                        },
                        "url": {
                            "raw": f"{BASE_URL}/{resource_path}/1",
                            "host": ["{{baseUrl}}"],
                            "path": ["api", entity_name, "1"]
                        }
                    },
                    "response": [] 
                },
                {
                   "name": f"Delete {entity_name}",
                    "request": {
                        "method": "DELETE",
                        "header": [],
                        "url": {
                            "raw": f"{BASE_URL}/{resource_path}/1",
                            "host": ["{{baseUrl}}"],
                            "path": ["api", entity_name, "1"]
                        }
                    },
                    "response": [] 
                }
            ]
        }
        items.append(entity_folder)

    collection = {
        "info": {
            "_postman_id": "b3e9c1c0-0e1a-4b1e-9c1c-0e1a4b1e9c1c",
            "name": "Consulcon Full CRUD (Smarter Data)",
            "schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
        },
        "item": [
            {
                "name": "Auth",
                "item": [
                    {
                        "name": "Login",
                        "request": {
                            "method": "POST",
                            "header": [{"key": "Content-Type", "value": "application/json", "type": "text"}],
                            "body": {
                                "mode": "raw",
                                "raw": "{\n    \"username\": \"veronica\",\n    \"password\": \"6309558\"\n}"
                            },
                            "url": {
                                "raw": "{{baseUrl}}/api/auth/login",
                                "host": ["{{baseUrl}}"],
                                "path": ["api", "auth", "login"]
                            }
                        },
                        "response": []
                    }
                ]
            },
            {
                "name": "Entities",
                "item": items
            }
        ],
        "variable": [
            {
                "key": "baseUrl",
                "value": "http://localhost:3010",
                "type": "string"
            }
        ]
    }

    with open(OUTPUT_FILE, "w") as f:
        json.dump(collection, f, indent=4)
    print(f"Generated collection at {OUTPUT_FILE}")

if __name__ == "__main__":
    generate_collection()
