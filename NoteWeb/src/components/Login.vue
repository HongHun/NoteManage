<!--
 * @Author: your name
 * @Date: 2022-01-11 20:29:23
 * @LastEditTime: 2022-01-12 18:07:08
 * @LastEditors: Please set LastEditors
 * @Description: 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 * @FilePath: \NoteWeb\src\components\Login.vue
-->

<template>
<div id="login">
  <img alt="登录页面" src="../assets/NoteLog.png">
  <el-form
    :model="ruleForm2"
    status-icon
    :rules="rules2"
    ref="ruleForm2"
    label-width="100px"
    class="loginRuleForm"
  >
  <el-form-item label="账号" prop="account" >
      <el-input
        type="text"
        v-model="ruleForm2.UserGUID"
        auto-complete="off"
      ></el-input>
    </el-form-item>
    <el-form-item label="密码" prop="pass">
      <el-input
        type="password"
        v-model="ruleForm2.password"
        auto-complete="off"
      ></el-input>
    </el-form-item>
    <el-form-item label="确认密码" prop="checkPass">
      <el-input
        type="password"
        v-model="ruleForm2.checkPass"
        auto-complete="off"
      ></el-input>
    </el-form-item>
    <el-form-item label="年龄" prop="age">
      <el-input v-model.number="ruleForm2.age"></el-input>
    </el-form-item>
    <el-form-item>
      <el-button type="primary" @click="submitForm('ruleForm2')"
        >提交</el-button
      >
      <el-button @click="resetForm('ruleForm2')">重置</el-button>
    </el-form-item>
  </el-form>
</div>
</template>

<script>
const axios = require('axios');

export default {
  data() {
    // 年龄校验
    var checkAge = (rule, value, callback) => {
      if (!value) {
        return callback(new Error("年龄不能为空"));
      }
      setTimeout(() => {
        if (!Number.isInteger(value)) {
          callback(new Error("请输入数字值"));
        } else {
          if (value < 18) {
            callback(new Error("必须年满18岁"));
          } else {
            callback();
          }
        }
      }, 1000);
    };
    // 也用户名校验
     var validateAccount = (rule, value, callback) => {
      if (value === "") {
        callback(new Error("请输入账号"));
      } else {
        callback();
      }
    };
    // 密码校验
    var validatePass = (rule, value, callback) => {
      if (value === "") {
        callback(new Error("请输入密码"));
      } else {
        if (this.ruleForm2.checkPass !== "") {
          this.$refs.ruleForm2.validateField("checkPass");
        }
        callback();
      }
    };
    // 二次密码校验
    var validatePass2 = (rule, value, callback) => {
      if (value === "") {
        callback(new Error("请再次输入密码"));
      } else if (value !== this.ruleForm2.password) {
        callback(new Error("两次输入密码不一致!"));
      } else {
        callback();
      }
    };
    return {
      ruleForm2: {
        UserGUID: "",
        password: "",
        checkPass: "",
        age: ""
      },
      rules2: {
        account: [{ validator: validateAccount, trigger: "blur" }],
        pass: [{ validator: validatePass, trigger: "blur" }],
        checkPass: [{ validator: validatePass2, trigger: "blur" }],
        age: [{ validator: checkAge, trigger: "blur" }]
      },
      userInfo: {
        UserGUID: "330DA93D-A581-450B-9109-E07947349A20",
        Password: "123456"
      }
    };
  },
  methods: {
    // 提交
    submitForm(formName) {
      var me = this;
      me.$refs[formName].validate(valid => {
        if (valid) {
          axios({
                method: 'post',
                url: '/MyUser/LoginIndex',
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(this.userInfo)
          }).then(function(res) {
            console.log(res);
            console.log(res.data);
            console.log(res.data.Status);
            if (res.status === 200) {
              me.$router.push("/Home");
            } else {
              alert("error submit2!");
            }
          })
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
    resetForm(formName) {
      this.$refs[formName].resetFields();
    }
  }
};
</script>

<style>
#login {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin: 0 auto;
  width:600px;
  margin-top: 60px;
}

</style>
