import React from "react";
import "./../styles/Profile.css";

const Profile = () => {
    return (
        <article className="ProfileContainer">
            <p className="ProfileTitle">PROFILE PAGE</p>
            <img src="/images/angelo.png" />
            <p>ANGELO LOLO GUERRA</p>
            <p>ANGELO1783@GMAIL.COM</p>
            <p>EXPIRY DATE: UNKNOWN</p>
            <input type="button" value="SAVE CHANGES"/>
        </article>
    )
}

export default Profile;