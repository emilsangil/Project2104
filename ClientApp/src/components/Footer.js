import React from "react";
import "./../styles/Footer.css";


const Footer = () => {
    return (
        <footer className="FooterContainer">
            <footer className="CopyrightContainer">
                <p>© 2023 SNKY, Inc. All Rights Reserved</p>
            </footer>
            <footer className="ImageFooterContainer">
                <img src="/images/Sneaky2.png"/>
            </footer>
            <footer className="NameContainer">
                <p>EMIL</p>
                <p>|</p>
                <p>ANGELO</p>
                <p>|</p>
                <p>MICHAEL</p>
                <p>|</p>
                <p>INIGO</p>
            </footer>
        </footer>
    )
}

export default Footer;