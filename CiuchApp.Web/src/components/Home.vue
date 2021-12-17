<template>
    <div class="home">
        <h3>{{ msg }}</h3>
        <p>Welcome to your new single-page application, built a kakakk withh <a href="https://vuejs.org" target="_blank">Vue.js</a>.</p>
        <p>{{textValue}}</p>
        <button @click="Adde">Hello - Click on me!</button>
        <p>table</p>
        <ColorList />

    </div>
</template>

<script>
  import BusinessTripsList from './BusinessTripsList.vue'
  import ColorList from './ColorList.vue'
  export default {
    name: 'Home',
    created () {
      this.$store.dispatch('getBusinessTrips') // once created call action (dispatch)
    },
    components: {
      ColorList,
      BusinessTripsList
    },
    props: {
      msg: String
    },
    data () {
      return {
        textValue: 'inital text value'
      }
    },
    methods: {
      Adde () {
      this.textValue += 'e'
      this.$store.commit('addBusinessTrip', this.textValue.slice())
    }
    }
  };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
