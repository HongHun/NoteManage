<!--
 * @Author: your name
 * @Date: 2022-01-11 20:29:23
 * @LastEditTime: 2022-01-19 12:49:05
 * @LastEditors: Please set LastEditors
 * @Description: 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 * @FilePath: \NoteWeb\src\components\Login.vue
-->

<template>
<!-- todo: recode verification function -->
<div class="cardcontainer">
  <div class="box login">
    <div class="form-content" :rules="rules2">
      <div class="avtar">
        <div class="pic"><img src="../assets/1.jpg" alt=""></div>
      </div>
      <h1>Welcome back</h1>
      <form action="#" class="form"  ref="ruleForm2" :model="ruleForm2" :rules="rules2">
          <div>
            <i class="fa fa-user-o"></i>
            <input type="text" placeholder="username" v-model="ruleForm2.UserName">
          </div>
          <div>
            <i class="fa fa-key"></i>
            <input type="password" placeholder="password" v-model="ruleForm2.password">
          </div>
          <div class="btn">
            <button  @click="submitForm()">login</button>
          </div>
      </form>
      <p class="btn-something">
          Don't have an account ? <span class="signupbtn">signup</span>
      </p>
    </div>
  </div>
  <div class="box signup">
    <div class="form-content">
      <div class="avtar">
          <div class="pic"><img src="../assets/2.jpg" alt=""></div>
      </div>
      <h1>Let's get started</h1>
      <form action="#" class="form">
        <div>
          <i class="fa fa-user-o"></i>
          <input type="text" placeholder="username">
        </div>
        <div>
          <i class="fa fa-envelop-o"></i>
          <input type="email" placeholder="email">
        </div>
        <div>
          <i class="fa fa-key"></i>
          <input type="password" placeholder="password">
        </div>
        <div class="btn">
          <button>signup</button>
        </div>
      </form>
      <p class="btn-something">
        Already have an account? <span class="loginbtn">login</span>
      </p>
    </div>
  </div>
</div>
</template>

<style >
.cardcontainer {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    width: 20rem;
    height: 28rem;
    perspective: 1500px;
    -webkit-perspective: 1500px;
    -moz-perspective: 1500px;
}

.box {
    position: absolute;
    top: 0;
    left: 0;
    width: 20rem;
    height: 28rem;
    border-radius: 10px;
    cursor: pointer;
    backface-visibility: hidden;
    transition: all 0.5s;
    user-select: none;
}

.signup {
    /* background-color: blue; */
    transform: rotateY(-108deg);
}

.cardcontainer .form-content {
    position: relative;
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
    box-shadow: 0 0 1px #3399ff;
    border-radius: 30px;
    background-color: #fff;
}

.cardcontainer .form-content .avtar {
    display: flex;
    justify-content: center;
    align-items: center;
    width: 100%;
}

.cardcontainer .form-content .avtar .pic {
    position: relative;
    width: 80px;
    height: 80px;
    overflow: hidden;
    border-radius: 50%;
    border: 1px solid #3399ff;
}

.cardcontainer .form-content .avtar .pic img {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
}

.cardcontainer .form-content h1 {
    font-size: 1.6rem;
}

.cardcontainer .form {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
}

.cardcontainer .form input {
    width: 16rem;
    padding: 0.8rem;
    padding-left: 3rem;
    outline: none;
    border: none;
    border-radius: 15px;
    box-shadow: 0 0 3px rgba(0, 0, 0, 0.2);
    margin: 5px;
}

.cardcontainer .form div {
    position: relative;
}

.cardcontainer .form div .fa {
    position: absolute;
    top: 18px;
    left: 25px;
}

.cardcontainer .form .btn {
    display: flex;
    justify-content: center;
    align-items: center;
    width: 100%;
    margin-top: 10px;
}

.cardcontainer .form .btn button {
    text-transform: uppercase;
    padding: 8px;
    border: none;
    outline: none;
    background-color: #0066ff;
    color: #fff;
    width: 12rem;
    border-radius: 30px;
    cursor: pointer;
}

.cardcontainer .btn-something {
    color: #888;
    font-size: 14px;
}

.cardcontainer .btn-something span {
    color: #0066ff;
    cursor: pointer;
    font-weight: 500;
}

svg {
    position: absolute;
    bottom: 0;
    z-index: -1;
}

.user {
    position: absolute;
    top: 16rem;
    left: 5rem;
}

.user .fa-user {
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 5rem;
    color: #0066ff;
}

.user {
    font-size: 1.6rem;
    text-transform: uppercase;
    user-select: none;
    text-shadow: 1px 1px 1px rgba(16, 16, 16, 0.1), 1px 2px 1px rgba(16, 16, 16, 0.1), 1px 3px 1px rgba(16, 16, 16, 0.1), 1px 4px 1px rgba(16, 16, 16, 0.1), 1px 5px 1px rgba(16, 16, 16, 0.1), 1px 6px 1px rgba(16, 16, 16, 0.1), 1px 7px 1px rgba(16, 16, 16, 0.1), 1px 8px 1px rgba(16, 16, 16, 0.1);
}
</style>
<script>
const axios = require('axios');
export default {
  data() {
    return {
      ruleForm2: {
        UserName: "",
        password: "",
        checkPass: "",
        age: ""
      },
      userInfo: {
        UserGUID: "330DA93D-A581-450B-9109-E07947349A20",
        Password: "123456"
      }
    };
  },
  mounted() {
    let login = document.querySelector(".login");
    let signup = document.querySelector(".signup");

    let loginbtn = document.querySelector(".loginbtn");
    let signupbtn = document.querySelector(".signupbtn");
    console.log(signupbtn)

    // let user = document.querySelector(".head");
    // 点击sign up/sign in之后，翻转两个形成连续效果
    signupbtn.addEventListener("click", () => {
        login.style.transform = "rotateY(180deg)"
        signup.style.transform = "rotateY(0deg)";
        // user.innerHTML = "create account"
    })

    loginbtn.addEventListener("click", () => {
        login.style.transform = "rotateY(0deg)"
        signup.style.transform = "rotateY(-180deg)";
        // user.innerHTML = "account login"
    })
  },
  methods: {
    // 提交
    submitForm() {
    if (this.ruleForm2.UserName && this.ruleForm2.password) {
      var me = this;
      axios({
        method: 'post',
        url: '/MyUser/LoginIndex',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(this.ruleForm2)
      }).then(function(res) {
        if (res.data.Status === 200) {
          localStorage.setItem('loginInfo', JSON.stringify(res.data));
          me.$router.push({path: '/home'});
        } else {
          alert("error submit2!");
        }
      });
    }
    this.errors = [];
    if (!this.ruleForm2.UserName) {
      this.errors.push('Name required');
    }
    if (!this.ruleForm2.password) {
      this.errors.push('password required');
    }
  },
  resetForm(formName) {
      this.$refs[formName].resetFields();
    }
  }
};
</script>
