import React, { useState, useEffect } from 'react';

const NumberList = () => {
    const [numbers, setNumbers] = useState<any[]>([]);


    useEffect(() => {
        fetch('numbers')
            .then((results) => {
                return results.json();
            })
            .then(data => {
                setNumbers(data)
            })
    }, [])

    return (
        <div>
            {
                (numbers.length > 0) ? numbers.map((obj) => <h4 key={numbers.findIndex( x => x == obj)}>{ obj.num } </h4>):<div>Your list is empty, click the button to add numbers.</div>
            }
        </div>
    )
}

export default NumberList; 
