import React from "react";
import "./../styles/HomeBanner.css";

const HomeBanner = ({imageUrl, ShoeClass, ShoeName}) => {
    return (
        <section className="HomebannerContainer">
            <section className="UpperTextContainer">
                <p>{ShoeClass}</p>
            </section>
            <section className="ImageHBContainer">
                <img src={imageUrl} />
            </section>
            <section className="LowerTextContainer">
                <p>{ShoeName}</p>
            </section>
        </section>
    )
}

export default HomeBanner;