// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './APP'
import VueRouter from 'vue-router'
import router from './router'
import ElementUI from 'element-ui'
import 'element-ui/lib/theme-chalk/index.css'
import axios from 'axios'
import global from './components/Global.vue'
import qs from 'qs'

Vue.config.productionTip = false
// ElementUI
Vue.use(ElementUI)
Vue.prototype.GLOBAL = global;
// 设置baseURL
axios.defaults.baseURL = global.BASE_URL;
// axois
Vue.prototype.$ajax = axios;
// json格式
Vue.prototype.$qs = qs;
// 数据类型修改为json
axios.defaults.headers.post['Content-Type'] = 'application/json';
// 使用路由
Vue.use(VueRouter)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
