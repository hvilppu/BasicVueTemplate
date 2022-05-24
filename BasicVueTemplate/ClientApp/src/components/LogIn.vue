<template>
    <h1 id="tableLabel">LogIn</h1>
    <input v-model="userName"><br />
    <input v-model="passWord"><br />
    <button @click="logInGet">Log In</button>
</template>

<script>
    import axios from 'axios'
    export default {
        name: "LogIn",
        data() {
            return {
                forecasts: [],
                userName: "",
                passWord: "",
            }
        },
        methods: {
            getWeatherForecasts() {
                axios.get('/weatherforecast')
                    .then((response) => {
                        this.forecasts =  response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
            logIn() {
                axios.post('/authentication/Login', { userName: this.userName, passWord: this.passWord })
                    .then((response) => {
                        if (response) {
                            alert("Success");
                        }
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
            logInGet() {
                axios.get('/authentication/LoginGet?userName=' + this.userName + '&passWord=' + this.passWord)
                    .then((response) => {
                        if (response) {
                            alert("Success");
                        }
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            }
        },
        mounted() {
            this.getWeatherForecasts();
        }
    }
</script>