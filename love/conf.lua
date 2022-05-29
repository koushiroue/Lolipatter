-- CEL 2022

function love.conf(t)
    t.window.width = 640
    t.window.height = 480
    t.window.title = "Lolipatter"
    t.window.icon = "assets/icon/!eye.png"

    t.window.highdpi = true
    t.window.usedpiscale = true

    t.modules.joystick = false
    t.modules.physics = false
    t.accelerometerjoystick = false

    t.version = "11.4"
end