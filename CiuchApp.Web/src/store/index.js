import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    colors: null
  },
  mutations: {
    updateColors (state, colors) {
      state.colors = colors
    }
  },
  actions: {
    getColors ({ commit }) {
      axios.get('api/colors').then(result => commit('updateColors', result.data))
    }
  },
  modules: {
  }
})
