<template>
<div>
    <ul v-if="votes">
        <li v-for="(vote,index) in votes" v-bind:key="index">
            <span>{{vote.user}}</span>
            <span>{{vote.votes}}</span>
        </li>
    </ul>
</div>
</template>

<script>
    const axios = require('axios');
   export default {
       name: 'chart',

       mounted (){
           this.getVotes();
       },

       data() {
           return {
               votes: null
           }
       },

       methods: {
           getVotes(){
               
               axios.get('https://localhost:5001/vote')
                .then((response) => {
                    this.votes = response.data;
                })
                .catch((response) => {
                    console.log("error:");
                    console.log(response.data.description);
                });
           }
       }
   }
</script>
