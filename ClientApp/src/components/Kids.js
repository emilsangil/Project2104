import React from 'react';
import HomeBanner from "./HomeBanner";
import "./../styles/Home.css";
import ShoesCard from "./ShoesCard";


const Kids = () => {
    return (
        <main className="MainContainer">
            <HomeBanner imageUrl="/images/Jordan1Kids.png" ShoeClass="AIR JORDAN 1" ShoeName="Nike Off-White Air Presto" />
            <ShoesCard />
        </main>
    )
}

export default Kids;