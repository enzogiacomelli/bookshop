import { createApp, reactive } from 'vue'
import App from './App.vue'

var books = reactive([
  {
    title: 'The Great Gatsby',
    price: 5.0,
    description: "descricao"
  },
  {
    title: 'To Kill a Mockingbird',
    price: 6.0,
    description: "descricao"
  }
])


createApp(App).provide('books', books).mount('#app')
