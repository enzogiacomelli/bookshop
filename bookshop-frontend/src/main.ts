import { createApp, reactive } from 'vue'
import App from './App.vue'
import './style.css';

var books = reactive([
  {
    title: 'The Great Gatsby',
    price: 5.0,
    description: "descricao",
    author: "fulano",
    showMoreInfo: false
  },
  {
    title: 'To Kill a Mockingbird',
    price: 6.0,
    description: "descricao",
    author: "fulano",
    showMoreInfo: false
  },
  {
    title: '1984',
    price: 7.0,
    description: "descricao",
    author: "fulano",
    showMoreInfo: false
  },
  {
    title: '1984',
    price: 7.0,
    description: "descricao",
    author: "fulano",
    showMoreInfo: false
  },
  {
    title: '1984',
    price: 7.0,
    description: "descricao",
    author: "fulano",
    showMoreInfo: false
  }

])


createApp(App).provide('books', books).mount('#app')
