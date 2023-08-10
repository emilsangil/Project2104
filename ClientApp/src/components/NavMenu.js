import React, { useEffect, useState } from 'react';
import { Link } from "react-router-dom";
import "./../styles/NavMenu.css"
import { useNavigate } from "react-router-dom";
import axios from "axios";


const NavMenu = () => {
    const nav = useNavigate();
    const [user, setUser] = useState({});

    useEffect(() => {
        const fetchUserData = async () => {
            const token = localStorage.getItem("token");
            const loggedInUser = localStorage.getItem("userLoggedIn")
            console.log(user);
            console.log(token)
            console.log(loggedInUser)

            if (!token) {
                nav("/signup")
            } else {
                try {
                    const response = await axios.get(`/api/user/${loggedInUser}`);
                    if (response.status === 200) {
                        setUser(response.data);
                        console.log('Fetch user success', response.data);
                    } else {
                        console.log('Fetch user failed', response);
                    }
                } catch (error) {
                    console.error('Error fetching user data:', error);
                }
            }
        }
        fetchUserData();

    }, []);

    const handleImageRedirect = () => {
        nav(`/profile/${user.id}`, { state: { user: user }})
    }

    return (
        <nav className="NavContainer">
            <nav className="ImgContainer1">
                <img src="/images/Sneaky1.png"/>
            </nav>
            <nav className="LinkContainer">
                <Link to="/">MEN</Link>
                <Link to="/women">WOMEN</Link>
                <Link to="/Kids">KIDS</Link>
                <Link to="/search">ALL</Link>
                <Link to="/favorites">FAVORITES</Link>
            </nav>
            <nav className="ImgContainer2" onClick={ handleImageRedirect }>
                <img src="/images/angelo.png" />
            </nav>
        </nav>
    )
}

export default NavMenu;