<template>
  <div class="about">
    <h1>This is an about page</h1>
    <Home />
  </div>
</template>

<script>
  import Home from '@/components/Home.vue'

  export default {
    name: 'About',
    components: {
      Home
    }
  }
</script>
