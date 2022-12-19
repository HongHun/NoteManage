import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import Login from '@/components/Login.vue'
import Home from '@/components/Home.vue'

Vue.use(Router)

const router = new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      redirect: '/Login'
    },
    {
      path: '/Login',
      name: 'Login',
      component: Login
    },
    {
      path: '/HelloWorld',
      name: 'HelloWorld',
      component: HelloWorld,
      meta: {
        auth: true
      }
    },
    {
      path: '/Home',
      name: 'Home',
      component: Home,
      meta: {
        auth: true
      }
    }
  ]
})
// 路由守卫
router.beforeEach((to, from, next) => {
  // to 要跳转到的路径
  // from从哪个路径来
  // next往下执行的回调
  // 在localStorage中获取token,后续改成从数据库获取是否有用户信息
  let token = localStorage.getItem('userName');
  if (to.meta.auth) {
    // 如果token存在直接跳转
    if (token) {
      next()
    } else {
      // 否则跳转到login登录页面
      next({
        path: '/login',
        query: {
          redirect: to.fullPath
        }
      })
    }
  } else {
    next();
  }
})
export default router;
