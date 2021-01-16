<template>
  <div id="app">
    <home></home>
    <pizzas></pizzas>
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
  </div>

</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import Home from './Home.vue'

export default {
  name: 'App',
  components: {
    HelloWorld,
    Home
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
