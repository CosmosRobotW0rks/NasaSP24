<script setup>
definePageMeta({
    layout: "landing",
});
</script>

<template>
    <LandingContainer class = "bg-red-950">
        <main class="bg-red-950 text-white px-10 py-10 pt-10 min-h-screen">
            <div class="chat-container">
                <div class="messages-container">
                    <div v-for="(msg, index) in messages" :key="index" :class="msg.type">
                        {{ msg.text }}
                    </div>
                </div>
                <div class="input-container">
                    <input v-model="userMessage" placeholder="Type a message..." @keyup.enter="sendMessage" />
                    <button @click="sendMessage">Send</button>
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
    methods: {
        async sendMessage() {
            if (this.userMessage.trim() === '') return;

            // Add user's message to chat
            this.messages.push({ text: this.userMessage, type: 'user' });

            try {
                // Send the message to ASP.NET backend
                const response = await axios.post('https://localhost:5001/api/Chatbot/sendMessage', {
                    message: this.userMessage
                });

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
    background-color: #f5f5f5;
    color: black;
    border-radius: 10px;
    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
    height: 800px;
    display: flex;
    flex-direction: column;
}

.messages-container {
    flex-grow: 1;
    overflow-y: auto;
    margin-bottom: 10px;
}

.user {
    background-color: #007bff;
    color: white;
    text-align: right;
    padding: 10px;
    margin: 10px;
    border-radius: 20px 20px 5px 20px;
    word-wrap: break-word;
    /* Ensure long words break within bubbles */
}

.bot {
    background-color: #ececec;
    color: #333;
    text-align: left;
    padding: 10px;
    margin: 10px;
    border-radius: 20px 20px 20px 5px;
    word-wrap: break-word;
}


.input-container {
    display: flex;
    align-items: center;
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
