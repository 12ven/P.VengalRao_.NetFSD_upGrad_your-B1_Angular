class Animal{
    makeSound(){
        return 'Generic Animal SOund';
    }
}

class Dog extends Animal{
    makeSound(){
        return "Dog Sound: Bow bow";
    }

}

class Cat extends Animal{
    makeSound(){
        return 'Cat Sound: Meow meow';
    }
}

class Cow extends Animal{
    makeSound(){
        return 'Cow Sound: Moo moo'
    }
}

let animals =[
    new Dog(),
    new Cat(),
    new Cow()
]

animals.forEach(a=>console.log(a.makeSound()));