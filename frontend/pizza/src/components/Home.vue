<template>
<div>
    <h1>{{texto}}</h1>
     <div class="chart">
        <chart></chart>
    </div>
</div>
</template>

<script>
   export default {
       name: 'home',

       data() {
           return {
               texto: 'Home Pizza Lovers'
           }
       }
   }
</script>
