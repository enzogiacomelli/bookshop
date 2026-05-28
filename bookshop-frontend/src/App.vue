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

    <p>
      Clique no botão "Mais informações" para ver mais detalhes sobre cada livro.
    </p>

    <div class="container-buttons"> 
      <button class="small-button" @click="books.forEach(book => book.showMoreInfo = true)">Exibir detalhes de todos os livros</button>
      <button class="small-button" @click="books.forEach(book => book.showMoreInfo = false)">Esconder detalhes de todos os livros</button>
    </div>

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
