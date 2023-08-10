import React from 'react';
import HomeBanner from "./HomeBanner";
import "./../styles/Home.css";
import ShoesCard from "./ShoesCard";


const Women = () => {
    return (
        <main className="MainContainer">
            <HomeBanner imageUrl="/images/Jordan1Valentines.png" ShoeClass="AIR JORDAN 1" ShoeName="Retro High GG Valenties" />
            <ShoesCard />
        </main>
    )
}

export default Women;
