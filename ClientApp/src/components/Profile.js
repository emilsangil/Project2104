import React, { useEffect, useState } from "react";
import "./../styles/Profile.css";
import axios from "axios";
import { useNavigate, useLocation } from "react-router-dom";

const Profile = () => {
    const location = useLocation();
    const nav = useNavigate();
    const user = location.state.user;

    useEffect(() => {
        const token = localStorage.getItem("token");
        const loggedInUser = localStorage.getItem("userLoggedIn")
        console.log(user);
        console.log(token);
        console.log(loggedInUser);

        if (!token) {
            nav("/signup")
        }


    }, [user]);

    const handleLogout = () => {
        localStorage.removeItem('token');
        localStorage.removeItem('userLoggedIn');
        nav('/signup');
    }


    return (
        <article className="ProfileContainer">
            <p className="ProfileTitle">PROFILE PAGE</p>
            <img src="/images/angelo.png" />
            <p>{ user.name }</p>
            <p>{ user.email}</p>
            <p>EXPIRY DATE: UNKNOWN</p>
            {/*<input type="button" value="SAVE CHANGES" />*/}
            <input type="button" value="LOGOUT" onClick={ handleLogout} />
        </article>
    )
}

export default Profile;