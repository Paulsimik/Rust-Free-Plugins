# Raid Markers
    Make markers on the map if players destroy entities (buildings) or additional prefabs with explosives.

# Permissions
    raidmarkers.allow

# Chat Commands
    /rmtest - make a test raid marker at your position

# Configuration
```
{
  "Blaclisted prefabs": [
    "wall.external.high.wood",
    "wall.external.high.stone"
  ],
  "Additional prefabs": [
    "cupboard.tool.deployed"
  ],
  "Distance when place new marker from another marker": 100,
  "Marker configuration": {
    "Alpha": 0.6,
    "Radius": 0.7,
    "Color1": "#000000",
    "Color2": "#FF0000",
    "Duration": 90.0
  },
  "version": {
    "Major": 1,
    "Minor": 0,
    "Patch": 0
  }
}
```