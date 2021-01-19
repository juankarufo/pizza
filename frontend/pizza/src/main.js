import Vue from 'vue'
import App from './App.vue'
import Home from './components/Home.vue'
import Pizzas from './components/Pizzas.vue'

Vue.config.productionTip = false

Vue.component('home',Home);
Vue.component('pizzas',Pizzas);

new Vue({
  render: h => h(App),
}).$mount('#app')

