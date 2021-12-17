<template>
  <div>
    <p v-for="(businessTrip, index) in businessTrips" :key="index">{{businessTrip}}</p>
  </div>
</template>

<script>
  export default {
    name: 'BusinessTripsList',
    computed: {
      businessTrips () {
        return this.$store.state.businessTrips
      }
    }
  };
</script>
