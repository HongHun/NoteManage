<template>
    <div class="hello">
      <h1>{{ msg }}</h1>
      <button  @click="getChickenSoup()">next</button>
    </div>
  </template>

  <script>
  const axios = require('axios');

  export default {
    name: 'ChickenSoup',
    data () {
      return {
        msg: '知道级处就是行！'
      }
    },
    methods: {
        getChickenSoup() {
            var me = this;
            axios({
                method: 'get',
                url: '/ChickenSoup/GetSoup',
                contentType: "application/json; charset=utf-8"
          }).then(function(res) {
            console.log(res.data.Data);
            if (res.data.Status === 200) {
              me.msg = res.data.Data;
            } else {
              alert("未获取到数据！");
            }
          })
        }
    }
  }
  </script>
  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  h1, h2 {
    font-weight: normal;
  }
  ul {
    list-style-type: none;
    padding: 0;
  }
  li {
    display: inline-block;
    margin: 0 10px;
  }
  a {
    color: #42b983;
  }
</style>
