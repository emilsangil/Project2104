import React from 'react';
import { Link } from "react-router-dom";
import "./../styles/NavMenu.css"


const NavMenu = () => {
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
            <nav className="ImgContainer2">
                <img src="/images/angelo.png" />
            </nav>
        </nav>
    )
}

export default NavMenu;