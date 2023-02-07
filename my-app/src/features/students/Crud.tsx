import { useAppSelector, useAppDispatch } from '../../app/hooks';
import {
    decrement,
    increment,
    incrementByAmount,
    incrementAsync,
    incrementIfOdd,
    selectCount,
} from './crudSlice';

import './Crud.scss';
import { useState } from 'react';
import { Container, Grid } from '@mui/material';

export function Crud() {
    const dispatch = useAppDispatch();
    const count = useAppSelector(selectCount);
    const [incrementAmount, setIncrementAmount] = useState('2');
    const incrementValue = Number(incrementAmount) || 0;

    return (
        <div>
            <Container>
                <strong>CRUD Operations</strong>
                <Grid container marginTop={0} spacing={2} width={"400px"}>
                    <Grid item sm={4}>
                        <div>Id</div>
                        <input
                            className={"textbox"}
                            aria-label="Id"
                            value={incrementAmount}
                            onChange={(e) => setIncrementAmount(e.target.value)}
                        />
                    </Grid>
                    <Grid item sm={4}>
                        <div>Name</div>
                        <input
                            className={"textbox"}
                            aria-label="Name"
                            value={incrementAmount}
                            onChange={(e) => setIncrementAmount(e.target.value)}
                        />
                    </Grid>
                    <Grid item sm={4}>
                        <button
                            className={"button"}
                            onClick={() => dispatch(incrementByAmount(incrementValue))}
                        >
                            Add
                        </button>
                    </Grid>
                    <Grid item sm={8
                    }>
                        <div>Id</div>
                        <input
                            className={"textbox"}
                            aria-label="Id"
                            value={incrementAmount}
                            onChange={(e) => setIncrementAmount(e.target.value)}
                        />
                    </Grid>
                    <Grid item sm={4}>
                        <button
                            className={"button"}
                            onClick={() => dispatch(incrementByAmount(incrementValue))}
                        >
                            Delete
                        </button>
                    </Grid>
                    <Grid item sm={4}>
                        <div>Id</div>
                        <input
                            className={"textbox"}
                            aria-label="Id"
                            value={incrementAmount}
                            onChange={(e) => setIncrementAmount(e.target.value)}
                        />
                    </Grid>
                    <Grid item sm={4}>
                        <div>Name</div>
                        <input
                            className={"textbox"}
                            aria-label="Name"
                            value={incrementAmount}
                            onChange={(e) => setIncrementAmount(e.target.value)}
                        />
                    </Grid>
                    <Grid item sm={4}>
                        <button
                            className={"button"}
                            onClick={() => dispatch(incrementByAmount(incrementValue))}
                        >
                            Update
                        </button>
                    </Grid>
                </Grid>
            </Container>
        </div>
    );
}