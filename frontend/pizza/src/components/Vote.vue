<template>
<div>
    <button v-if="logged" @click="vote()">Vote!</button>
</div>
</template>

<script>
const axios = require('axios');
   export default {
       name: 'vote',

       data() {
           return {
               loggedd: true,
               inputlogin: ''
           }
       },

       props:['logged', 'username'],

       methods: {
           vote(){
                let postBody = { Login: this.username};
                axios.post('https://localhost:5001/vote', postBody)
                .then((response) => {
                    if(response.data == 'ok')
                    {
                        console.log("vote registered");
                        console.log(response.data);
                    }
                })
                .catch((response) => {
                    console.log("vote error:");
                    console.log(response.data.description);
                });
              
           }
           
       }
   }
</script>
