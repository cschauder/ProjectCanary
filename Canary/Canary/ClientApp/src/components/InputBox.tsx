import React, { useState, useEffect } from 'react';

const InputBox = () => {
    const [message, setMessage] = useState<any>(); 

    function addToList() {
        const val = document.querySelector('textarea')!.value;
        const valObject = {
            sevenDigit: val
        }

        fetch('numbers', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(valObject)
        })
            .then(response => response.json())
            .then(res => {
                if (res) {
                    setMessage('The number was successfully added')
                    console.log('SUCCESS', message); 
                }
            })
            .catch((error) => {
                // catch any unexpected errors
                console.log(error);
            })
    }

    function resetState() {
        setMessage(''); 
    }

    return (
        <div>
            <h4>Input a number</h4>
            <div className="form-group">
                <textarea rows={3} cols={50} onChange={resetState}>
                </textarea>
            </div>
            <div className="form-group">
                <button className="btn btn-primary" onClick={addToList}>Add To List</button>
            </div>
            {/*<button>Clear</button>*/}
            <div>{message}</div>
        </div>
    )
}

export default InputBox; 
