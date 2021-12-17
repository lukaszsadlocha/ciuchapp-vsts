module.exports = {
  devServer: {
    proxy: { // proxy configuraion
      '/api': {
        target: 'http://localhost:13121',
        changeOrigin: true
      }
    }
  }
}
