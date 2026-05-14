<script setup lang="ts">

import { inject } from 'vue'


const books = inject('books')

</script>


<template>

  <div>
    <h1>Bookshop</h1>
    <p>
      Livros disponiveis:
    </p>

    <ul v-for="book in books">
      <li>Titulo: {{book.title}}</li>
      <li>Preço: {{book.price}}</li>
      <li>Descrição: {{book.description}}</li>
      <br>
    </ul>
  </div>

</template>

<style scoped></style>
