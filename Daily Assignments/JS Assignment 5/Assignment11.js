class User {
    constructor(password) {
        this._password = password;
    }

    set password(newPassword) {
        if (newPassword.length >= 6) {
            this._password = newPassword;
        } else {
            console.log("Password must be at least 6 characters long.");
        }
    }

    get password() {
        return this._password;
    }
}

let u1 = new User("secret123");
console.log(u1.password);

u1.password = "123"; 
u1.password = "newpass123";
console.log(u1.password);