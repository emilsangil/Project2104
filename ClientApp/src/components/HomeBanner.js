import React from "react";
import "./../styles/HomeBanner.css";

const HomeBanner = () => {
    return (
        <section className="HomebannerContainer">
            <section className="UpperTextContainer">
                <p>AIR JORDAN 1</p>
            </section>
            <section className="ImageHBContainer">
                <img src="/images/RetroHighOGChicago1.png"/>
            </section>
            <section className="LowerTextContainer">
                <p>RETRO HIGH OG CHICAGO</p>
            </section>
        </section>
    )
}

export default HomeBanner;