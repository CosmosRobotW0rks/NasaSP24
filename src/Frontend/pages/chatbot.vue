<script setup>
definePageMeta({
    layout: "landing",
});

var SessionID = "";

async function GenerateSID() {
    const response = await axios.post('https://nasaspapi.cosmos7742.com/chatbot/createsession');
    if (response.status != 200) console.log("Error while generating SID // response status is not 200");
    SessionID = response.data;
    document.getElementById("session_id").value = SessionID;
}

async function SENNDD() {
    const msg = document.getElementById("text_input").value;
    console.log("MESSSS");
    console.log(msg);

    if (msg.trim() === '') return;

    // Add user's message to chat
    this.messages.push({ text: msg, type: 'user' });

    try {
        // Send the message to ASP.NET backend

        console.log(msg);

        const response = await axios.post(`https://nasaspapi.cosmos7742.com/chatbot/message?sid=${SessionID}&message=${msg}`);

        // Add bot's response to chat
        this.messages.push({ text: response.data, type: 'bot' });
    } catch (error) {
        console.error('Error sending message:', error);
        this.messages.push({ text: 'Error communicating with bot', type: 'error' });
    }

    // Clear the input
    this.userMessage = '';

    // Scroll to the bottom
    this.$nextTick(() => {
        const container = this.$el.querySelector('.messages-container');
        container.scrollTop = container.scrollHeight;
    });
}

GenerateSID();
</script>

<template>
    <LandingContainer class="">
        <main class="max-h-full text-white px-10 py-10 pt-10 min-h-screen" style="background-image: url('/img/cossmos');">
            <div class="chat-container">
                <div class="messages-container">
                    <div class="whitespace-pre-line" v-for="(msg, index) in messages" :key="index" :class="msg.type">
                        {{ msg.text }}
                    </div>
                </div>
                <div class="input-container">
                    <input id="text_input" v-model="userMessage" placeholder="Type a message..." @click="sendMessage" />
                    <input id="session_id" hidden>
                    <button @click=sendMessage>Send</button>
                </div>
            </div>
        </main>
    </LandingContainer>
</template>

<script>
import axios from "axios";

export default {
    data() {
        return {
            messages: [
                { text: "Hi friend! I am your exoplanet assistant to help you generate more things to question about exoplanets. You know, this is the best way to learn! Give me any topic you would like to discover and I'll give you questions.", type: "bot" },
            ],
            newMessage: "",
        };
    },
    mounted() {
        // Disable scrolling on the page
        //document.body.style.overflow = "hidden";
    },
    beforeUnmount() {
        // Re-enable scrolling when the component is destroyed or user navigates away
        document.body.style.overflow = "auto";
    },
    computed: {
        dynamicWidth() {
            const length = this.userInput.length;
            let width = `${length * 2 + 10}px`; // Adjust size increment per char
            // Ensure the width stays between minWidth and maxWidth
            if (parseInt(width) > 500) {
                width = '500px';
            }
            return {
                minWidth: this.minWidth,
                width: width
            };
        }
    },

    methods: {
        getBubbleStyle(message) {
            const textLength = message.length;

            // Calculate width based on character count
            const width = Math.min(Math.max(textLength * 8, 50), 500); // Minimum width of 50px, max of 500px

            return {
                width: `${width}px`
            };
        },
        async sendMessage() {
            const msg = document.getElementById("text_input").value;
            console.log("MESSSS");
            console.log(msg);

            if (msg.trim() === '') return;

            // Add user's message to chat
            this.messages.push({ text: msg, type: 'user' });

            try {
                // Send the message to ASP.NET backend

                console.log(msg);

                const SessionID = document.getElementById("session_id").value;

                const response = await axios.post(`https://nasaspapi.cosmos7742.com/chatbot/message?sid=${SessionID}&message=${msg}`);

                // Add bot's response to chat
                this.messages.push({ text: response.data, type: 'bot' });
            } catch (error) {
                console.error('Error sending message:', error);
                this.messages.push({ text: 'Error communicating with bot', type: 'error' });
            }

            // Clear the input
            this.userMessage = '';

            // Scroll to the bottom
            this.$nextTick(() => {
                const container = this.$el.querySelector('.messages-container');
                container.scrollTop = container.scrollHeight;
            });
        }
    }

};
</script>


<style scoped>
.chat-container {
    max-width: w-full;
    margin: 20px auto;
    padding: 10px;
    background-color: rgba(0, 0, 0, 0);
    color: black;
    border-radius: 10px;
    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
    height: 800px;
    display: flex;
    flex-direction: column;
    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
}

.messages-container {
    flex-grow: 1;
    overflow-y: auto;
    margin-bottom: 10px;
    background-image: "/img/cosmos_background.PNG";

}

.user {
    background-color: #007bff;
    color: white;
    text-align: right;
    padding: 10px;
    margin: 10px;
    margin-left: auto;
    border-radius: 20px 20px 5px 20px;
    max-width: 15%;
    /* Set a max-width for larger messages */
    word-wrap: break-word;
    
    /* Ensure long words wrap */
}

.bot {
    background-color: #ececec;
    color: #333;
    text-align: left;
    padding: 10px;
    margin: 10px;
    border-radius: 20px 20px 20px 5px;
    max-width: 60%;
    /* Set a max-width for larger messages */
    word-wrap: break-word;
}


.input-container {
    display: flex;
    align-items: center;
    margin-bottom: 10px;
}

input {
    flex: 1;
    padding: 10px;
    border: none;
    border-radius: 5px;
    margin-right: 5px;
}

button {
    padding: 10px 20px;
    background-color: #0084ff;
    color: white;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}

button:hover {
    background-color: #0071e1;
}
</style>
