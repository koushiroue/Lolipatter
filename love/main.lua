local utf8 = require("utf8")

function love.load()
	-- lovepotion exculsive config
    -- if we're on Switch, set extended as our current font
    if love._console_name == "Switch" then
        love.graphics.setNewFont("nintendo extended", 14)
    end
	Image1 = love.graphics.newImage("assets/image/image_0.png")
	love.graphics.setNewFont(24)
	love.graphics.setBackgroundColor(255,255,255)
end

function love.draw()
	love.graphics.draw(Image1, 32, 24)

end

