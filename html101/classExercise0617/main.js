let name = "James";

if(name.length > 3){
    console.log("cool dude");
}

for (let index = 0; index < 10; index++) {
    console.log(index);
    
}

let counter = 0;
while (counter < 10) {
    console.log("ok");
    counter++;
}

function printInput(input) {
    console.log(input);
}

printInput("james");
printInput(2);
printInput(true);

let dog = {
    name: "fido",
    age: 10,
    bark: function(){
        console.log("bark");
    }
}

dog.bark();

class Animal{
    name = "Lenny";
    collar = true;
    legs = 16;

    constructor(name, collar, legs){
        this.name = name;
        this.collar = collar;
        this.legs = legs;
    }

    makeNoise = function() {
        console.log("ahhh, i have too many legs");
    }
}

var animal = new Animal();

var nameArray = [ "Jimmy", "Johns", "I'm", "hungry" ];

var animals = [new Animal("jimmy", false, 2), new Animal()];

console.log(`${animal.name} ${animal.collar}`);