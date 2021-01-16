<template>
<div>
    <h1>{{texto}}</h1>
</div>
</template>

<script>
    const axios = require('axios');
   export default {
       name: 'pizzas',

       mounted (){
           this.getPizzas();
       },

       data() {
           return {
               texto: 'pizzas component',
               pizzas: null
           }
       },

       methods: {
           getPizzas(){
               
               axios.get('https://localhost:5001/Pizza')
                .then(function (response) {
                    console.log(response.data);
                })
                .catch(function (response) {
                    console.log("error:");
                    console.log(response.data.description);
                });
           }
       }
   }
</script>
