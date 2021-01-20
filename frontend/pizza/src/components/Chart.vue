<script>
import {  Bar, mixins } from 'vue-chartjs'
import axios from 'axios'

export default {
  mixins: [mixins.reactiveData],
  data() {
    return {
      chartData: ''
    }
  },
  extends: Bar,
  mounted() {
    this.renderChart(this.chartData)
  },
  created() {
    axios.get('https://localhost:5001/vote')
      .then(response => {
        // JSON responses are automatically parsed.
        const responseData = response.data
        this.chartData = {
          labels: responseData.map(item => item.user),
          datasets: [{
            label: 'Votes',
             backgroundColor: '#f87979',
             data: responseData.map(item => item.votes)
          }]
        }
      })
      .catch(e => {
        this.errors.push(e)
      })
  }
}
</script>


<style>
  .chart {
    max-width: 600px;
    margin:  150px auto;
  }
</style>