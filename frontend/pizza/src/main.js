import Vue from 'vue'
import App from './App.vue'
import Home from './components/Home.vue'
import Pizzas from './components/Pizzas.vue'
import Chart from './components/Chart.vue'
import Login from './components/Login.vue'

Vue.config.productionTip = false

Vue.component('home',Home);
Vue.component('pizzas',Pizzas);
Vue.component('chart',Chart);
Vue.component('login',Login);

new Vue({
  render: h => h(App),
}).$mount('#app')

