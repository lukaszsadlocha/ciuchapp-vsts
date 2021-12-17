<template>
    <div>
        <table>
            <thead>
                <tr>
                    <td>lp</td>
                    <td>id</td>
                    <td>name</td>
                </tr>
            </thead>
            <tbody>
                <tr v-for="(color, index) in colors" :key="index">
                    <td>{{index +1 }}</td>
                    <td>{{colors.id}}</td>
                    <td>{{colors.name}}</td>
                </tr>
            </tbody>
        </table>

    </div>
</template>

<script>
  export default {
    name: 'ColorList',
    computed: {
      colors () {
        return this.$store.state.businessTrips
    }
    }
  };
</script>
