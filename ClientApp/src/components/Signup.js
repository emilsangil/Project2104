import React, { useState } from "react";
import "./../styles/Signup.css";

const Signup = () => {
    const [username, setUsername] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [isSignup, setIsSignup] = useState(true);

    const switchToSignUp = () => {
        setIsSignup(true)
    }

    const switchToSignIn = () => {
        setIsSignup(false)
    }


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
                {isSignup ? <input type="button" value="SIGN UP" className="buttonSign buttonNotClicked" /> : <input type="button" value="SIGN IN" className="buttonSign buttonNotClicked" />}
            </article>
        </article>
    )
}

export default Signup;