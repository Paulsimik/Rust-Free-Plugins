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
  "Pickup any vehicles": true,
  "Pickup only your own vehicles": true,
  "Pickup require building priviledge": true,
  "Automatically mount players": false,
  "Item shortname for water entity": "kayak",
  "Item shortname for big models": "abovegroundpool.deployed",
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
    "snowmobile",
    "tomahasnowmobile",
    "tugboat"
  ],
  "version": {
    "Major": 1,
    "Minor": 1,
    "Patch": 3
  }
}
```

# Available Vehicles
    rhib, militaryboat, military
    car, car1, sedan
    boat, rowboat, motorboat
    ch, ch47, chinook
    copter, minicopter, mini
    horse, unicorn, testridablehorse
    balloon, hotairballoon
    scrap, scrapheli, scraphelicopter, helicopter
    car2, car3, car4 for 2-3-4 module cars
    submarinesolo
    submarineduo
    snowmobile, snow
    tomahasnowmobile, tsnow, tsnowmobile
    tugboat