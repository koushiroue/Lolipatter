local utf8 = require("utf8")

local splashy = require 'libs/splashy'

function love.load()
	-- lovepotion exculsive config
    -- if we're on Switch, set extended as our current font
    if love._console_name == "Switch" then
        love.graphics.setNewFont("nintendo extended", 14)
    end
	Image1 = love.graphics.newImage("assets/image/image_0.png",Image1)
	Intro = love.graphics.newImage("assets/image/intro.png",Intro)
	love.graphics.setNewFont(24)
	love.graphics.setBackgroundColor(255,255,255)

	splashy.addSplash(Intro, 2)
	splashy.onComplete(function() print("Hurray! This runs once after the splash screens are over.") end)

end
function love.draw()

	splashy.draw()
	--love.graphics.draw(Image1, 32, 24)

end

function love.update(dt)

	splashy.update(dt)

end