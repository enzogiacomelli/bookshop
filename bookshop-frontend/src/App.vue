<script setup lang="ts">

import { inject } from 'vue'
const books = inject('books')

</script>


<template>

  <div class="page">
    <h1>Bookshop</h1>
    <p>
      Livros disponiveis:
    </p>

    <div class="container-line">
      <div class="book-box" v-for="book in books">
        <span>Titulo: {{ book.title }}</span> <br>
        <span>Preço: {{ book.price }}</span> <br>
        <button @click="book.showMoreInfo = !book.showMoreInfo">Mais informações</button>
        <div class="description-box" v-if="book.showMoreInfo">
          <span>Autor: {{ book.author }}</span> <br>
          <span>Descrição: {{ book.description }}</span> <br>
        </div>
      </div>
    </div>
  </div>

</template>

<style scoped></style>
