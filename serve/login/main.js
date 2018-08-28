function login(){
    var bcrypt = require('bcryptjs');
    console.log(bcrypt.genSaltSync(10));
    var salt = transferSalt("GET");
}