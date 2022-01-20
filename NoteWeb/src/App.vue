<!--
 * @Author: your name
 * @Date: 2022-01-15 22:03:58
 * @LastEditTime: 2022-01-19 13:46:11
 * @LastEditors: your name
 * @Description: 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 * @FilePath: \NoteWeb\src\App.vue
-->
<template>
  <div id="app">
    <router-view></router-view>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import Home from './components/Home.vue'
import Login from './components/Login.vue'

export default {
  name: 'App',
  components: {
    HelloWorld,
    Home,
    Login
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
