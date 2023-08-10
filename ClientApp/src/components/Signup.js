import React, { useState, useEffect } from "react";
import "./../styles/Signup.css";
import axios from "axios";
import bcrypt from "bcryptjs";
import { useNavigate } from "react-router-dom";

const Signup = () => {
    const nav = useNavigate();
    const [username, setUsername] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [isSignup, setIsSignup] = useState(true);

    useEffect(() => {
        const token = localStorage.getItem("token");

        if (!token) {
            nav("/signup");
        }
    }, []);

    const switchToSignUp = () => {
        setIsSignup(true)
    }

    const switchToSignIn = () => {
        setIsSignup(false)
    }

    const handleSignup = async () => {
        try {
            const hashedPassword = bcrypt.hashSync(password, 10);
            const response = await axios.post("/api/user/create", {
                name: username,
                email: email,
                password: hashedPassword
            });

            if (!response.data) {
                alert("Error Signing up");
            }

            console.log("Signup successful:", response.data);
            setIsSignup(false);
        } catch (error) {
            console.log("Signup failed:", error);
        }
    };

    const handleLogin = async () => {
        try {
            const response = await axios.post("/api/user/login", {
                email: email,
                password: password
            });

            if (!response.data) {
                alert("Error logging in, Try again!")
            }

            console.log(response.data);
            const token = response.data.token;
            const userId = response.data.userId;
            localStorage.setItem("token", token);
            localStorage.setItem("userLoggedIn", userId);
            nav('/')

        } catch {
            console.log("login failed, error");
        }
    };


    return (
        <article className="SignupContainer">
            <article className="SignupImageContainer">
                <img src="/images/Sneaky1-lg.png"/>
            </article>
            <article className="SignupButtonContainer">
                <input type="button" value="SIGN UP" onClick={switchToSignUp} className={isSignup ? "buttonClicked" : "buttonNotClicked" } />
                <input type="button" value="SIGN IN" onClick={switchToSignIn} className={isSignup ? "buttonNotClicked" : "buttonClicked" } />
            </article>
            <article className="SignupInputContainer">
                {isSignup ? <><label htmlFor="username">USERNAME</label> <input id="username" type="text" value={username} onChange={(e) => setUsername(e.target.value)} /> </>: null}
                <label htmlFor="email">EMAIL</label>
                <input id="email" type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                <label htmlFor="password">PASSWORD</label>
                <input id="password" type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                {isSignup ? <input type="button" value="SIGN UP" className="buttonSign buttonNotClicked" onClick={handleSignup} /> : <input type="button" value="SIGN IN" className="buttonSign buttonNotClicked" onClick={ handleLogin } />}
            </article>
        </article>
    )
}

export default Signup;