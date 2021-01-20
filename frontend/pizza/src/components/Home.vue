<template>
<div>
    <h1>{{texto}}</h1>
    <pizzas></pizzas>
    <chart></chart>
</div>
</template>

<script>
   export default {
       name: 'home',

       data() {
           return {
               texto: 'Home component'
           }
       }
   }
</script>
