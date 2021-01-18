<template>
<div>
    <ul v-if="pizzas">
        <li v-for="(pizza,index) in pizzas" v-bind:key="index">
            <span>{{pizza.name}}</span>

        </li>
    </ul>
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
                .then((response) => {
                    this.pizzas = response.data;
                })
                .catch((response) => {
                    console.log("error:");
                    console.log(response.data.description);
                });
           }
       }
   }
</script>
