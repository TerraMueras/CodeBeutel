import json


data = json.load(open('muenster_spender_big.geojson', 'r'))

for x in data['features']:
    print(x)
    print(x["geometry"]["coordinates"][0])
    print(x["geometry"]["coordinates"][1])
    print(x["id"])
    
print(len(data["features"]))