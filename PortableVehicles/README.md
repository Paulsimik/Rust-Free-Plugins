# Portable Vehicles
    Gives vehicles as item to players .

# Permissions
    portablevehicles.use - to chat command
    portablevehicles.admin - to admin command
    portablevehicles.pickup - to pickup vehicles with hammer hit
    portablevehicles.fuel - auto fuel to vehicle

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
  "Check storages before pickup": true,
  "Need repair vehicles before pickup": false,
  "Auto amount fuel to vehicle": 0,
  "Item shortname for water entity": "kayak",
  "Item shortname for big models": "furnace.large",
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
    "Patch": 9
  }
}
```

# Available Vehicles
    rhib, militaryboat, military - 2783365542
    car, car1, sedan - 2783365060
    boat, rowboat, motorboat - 2783365250
    ch, ch47, chinook - 2783365479
    copter, minicopter, mini - 2906148311
    horse, unicorn, testridablehorse - 2783365408
    balloon, hotairballoon - 2783364912
    scrap, scrapheli, scraphelicopter, helicopter - 2783365006
    car2 - 2783364084
    car3 - 2783364660
    car4 - 2783364761
    submarinesolo - 2783365665
    submarineduo - 2783365593
    snowmobile, snow - 2783366199
    tomahasnowmobile, tsnow, tsnowmobile - 3000416835
    tugboat - 3000418301
    attackhelicopter, attackheli, attackcopter - 3284204081
    motorbike - 3284204457
    motorbikesidecar, motorsidecar, sidecar - 3284204759
    bicycle, pedalbike, bike - 3284205070
    trike, pedaltrike - 3284205351
    catapult - 3446373078
    siegetower, tower - 3446373165
    batteringram, ram - 3446372968
    ballista - 3446372639
