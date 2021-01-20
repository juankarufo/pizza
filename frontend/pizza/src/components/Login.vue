<template>
<div>
    <button v-if="!logged" @click="logInto()">Login</button>
    <button v-if="!logged" @click="signUp()">Sign Up</button>
    <input v-model="inputlogin" v-if="!logged" placeholder="user">
    <input v-model="inputpass" v-if="!logged" placeholder="password">
    <spam v-if="logged">Welcome {{username}}!!</spam>

    

</div>
</template>

<script>
const axios = require('axios');
   export default {
       name: 'login',

       data() {
           return {
               logged: false,
               username: '',
               inputlogin: null,
               inputpass: null


           }
       },

       methods: {
           logInto(){
                let postBody = { Login: this.inputlogin, Password: this.inputpass};
                axios.post('https://localhost:5001/login', postBody)
                .then((response) => {
                    if(response.data == 'login ok')
                    {
                        this.username = this.inputlogin;
                        this.logged = true;
                        console.log("added and logged user:");
                        console.log(response.data);
                    }
                })
                .catch((response) => {
                    console.log("login error:");
                    console.log(response.data.description);
                });
              
           },

           signUp(){
                let postBody = { Login: this.inputlogin, Password: this.inputpass};
                axios.post('https://localhost:5001/signup', postBody)
                .then((response) => {
                    if(response.data == 'signup OK')
                    {
                        this.username = this.inputlogin;
                        this.logged = true;
                        console.log("added and logged user:");
                        console.log(response.data);
                    }
                })
                .catch((response) => {
                    console.log("login error:");
                    console.log(response.data.description);
                });
              
           }
           
       }
   }
</script>
