(function(){

			//NEED TO ADD COLLISION DETECTION
	var canvas = document.getElementById('canvas'),
		ctx = canvas.getContext('2d'),
		dwarf = new Dwarf(ctx.canvas.width / 2 - 60, ctx.canvas.height - 140, 40),
		rocks = [];

	function Rock (x, y, speed){
		this.x = x;
		this.y = y;
		this.speed = speed;


		this.draw = function (ctx) {
			ctx.beginPath();
			ctx.moveTo(this.x, this.y);
			ctx.lineTo(this.x + 10, this.y + 13);
			ctx.lineTo(this.x + 22, this.y + 16);
			ctx.lineTo(this.x + 28, this.y + 10);
			ctx.lineTo(this.x + 30, this.y)
			ctx.closePath();
			ctx.stroke();

		};

		this.moveRockDown = function () {
			this.y += this.speed;
		};
	};
	
	function Dwarf (x, y, speed){
		this.x = x;
		this.y = y;
		this.speed = speed;
		this.rocks = [];
		var rockSpeed = 20;

		this.draw = function(ctx) {
				//hat
			ctx.beginPath();
			ctx.moveTo(this.x, this.y);
			ctx.lineTo(this.x + 20, this.y + 20);
			ctx.lineTo(this.x, this.y + 40);
			ctx.lineTo(this.x + 80, this.y + 40);
			ctx.closePath();
			ctx.stroke();
				//face
			ctx.beginPath();
			ctx.strokeRect(this.x + 20, this.y + 40, 40, 30);
			ctx.stroke();
				//cloth
			ctx.beginPath();
			ctx.moveTo(this.x + 20, this.y + 70);
			ctx.lineTo(this.x, this.y + 90);
			ctx.lineTo(this.x, this.y + 110);
			ctx.lineTo(this.x + 20, this.y + 90);
			ctx.lineTo(this.x, this.y + 140);
			ctx.lineTo(this.x + 80, this.y + 140);
			ctx.lineTo(this.x + 60, this.y + 90);
			ctx.lineTo(this.x + 80, this.y + 110);
			ctx.lineTo(this.x + 80, this.y + 90);
			ctx.lineTo(this.x + 60, this.y +70);
			ctx.stroke();
		};	

		this.moveLeft = function (){
			if (this.x > 0) {
				this.x -= speed;
			};
		};

		this.moveRight = function (){
			if (this.x < ctx.canvas.width - 80){
				this.x += speed;
			};
		};
	};

	document.body.addEventListener('keydown', function (e) {
		if (!e) {
			e = window.event;
		};

		switch(e.keyCode){
			case 37: dwarf.moveLeft(); break;
			case 39: dwarf.moveRight(); break;
		};
	});

	function createRocks(x, y, speed, array) {
		var i = 0;

		for(i = 0; i <= 6; i+=1){
			var rockStart = (Math.random() * ctx.canvas.width - 30) | 0;
			var rock = new Rock(rockStart, y, speed);
			array.push(rock);
			if (array.length == 6){
				return;
			};
		};
	};

	function drawAndMoveRocks(array) {
		if (array.length < 6) {
			createRocks(0, 0, 5, array);
		}
		else if (array.length == 6){
			for(var i in array) {
				array[i].draw(ctx);
				array[i].moveRockDown();
				if (array[i].y > ctx.canvas.height){
					array.splice(i, 1); break;
				};
				/* if (array[i].x < dwarf.x + 80  && array[i].x + 30  > dwarf.x &&
			    	array[i].y < dwarf.y + 140 && array[i].y + 16 > dwarf.y) {
					alert('Game over!');
				}; */	//Tried making a collision detection
			};
		};
	};

	function animationFrame(){
		ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
		dwarf.draw(ctx);
		drawAndMoveRocks(rocks);
		requestAnimationFrame(animationFrame);

	};
	requestAnimationFrame(animationFrame);

}());
