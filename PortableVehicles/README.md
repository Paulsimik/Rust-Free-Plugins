# Portable Vehicles
    Gives vehicles as item to players .

# Permissions
    portablevehicles.use - to chat command
    portablevehicles.admin - to admin command
    portablevehicles.pickup - to pickup vehicles with hammer hit

# Commands
    /pv 'vehicle name' - get the vehicle (need use permissions)
    /pv 'steamID/player name' 'vehicle name' - give vehicle to player (need admin permissions)

# Console Commands
    portablevehicles.give 'steamID/player name' 'vehicle name' - give vehicle to player (need admin permissions)

# Configuration
```
{
  "Chat Icon": 0,
  "Hits count to pickup vehicle": 5,
  "Automatically mount players": false,
  "Item shortname for water entity": "innertube",
  "Item shortname for ground entity": "box.wooden.large",
  "Blacklist pickupable vehicles shortname": [
    "rhib",
    "rowboat",
    "minicopter.entity",
    "sedantest.entity",
    "ch47.entity",
    "hotairballoon",
    "testridablehorse",
    "scraptransporthelicopter",
    "2module_car_spawned.entity",
    "3module_car_spawned.entity",
    "4module_car_spawned.entity",
    "submarinesolo.entity",
    "submarineduo.entity",
    "snowmobile"
  ],
  "version": {
    "Major": 1,
    "Minor": 1,
    "Patch": 2
  }
}
```

# Available Vehicles
    rhib
    car (sedan)
    boat
    ch47
    minicopter
    horse
    balloon
    scraphelicopter
    car2, car3, car4 for 2-3-4 module cars
    submarinesolo
    submarineduo
    snowmobile